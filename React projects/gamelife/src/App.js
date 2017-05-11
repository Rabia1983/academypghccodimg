import React, { Component } from 'react';
import './App.css';
import Board from './board'

class App extends Component {
constructor(props){
  super(props);
  this.gridLength=25;
  this.state = {
    currentboard:this.InisialBoard()
  }
this.makeCellLive = this.makeCellLive.bind(this);
this.updaterboard =  this.updaterboard.bind(this);
setTimeout(this.updaterboard, 2000);
}


emptyBoard(){
  var  empboard=[];
    for (var i =0;i<this.gridLength;i++){
      empboard[i]=[];
      for(var j=0;j<this.gridLength;j++){
      empboard[i][j]=false;
      }
    }
    return empboard;
}

InisialBoard(){

    var iniboard = this.emptyBoard();
      iniboard[5][2]= true;
      iniboard[5][3]= true;
      iniboard[5][4]= true;
      iniboard[1][4]= true;
      iniboard[0][3]= true;

    return iniboard;

}

makeCellLive(row,col){
 var tem = this.state.currentboard;
 tem[row][col]=true;
 this.setState({currentboard:tem});
}


updaterboard(){
  console.log("update board");
  var temboard=this.emptyBoard();
   var  myboard =this.state.currentboard;
   var liveNeighbor =0;
   for (var i =0;i<this.gridLength;i++){
     for(var j=0;j<this.gridLength;j++){

       liveNeighbor = 0;
        if (myboard[i][j + 1]) {
         liveNeighbor++;
             }
       if (myboard[i][j- 1]) {
         liveNeighbor++;
             }

       if (i< this.gridLength - 1) {
            if (myboard[i+ 1][j+ 1]) {
             liveNeighbor++;
             }
            if (myboard[i+ 1][j- 1]) {
             liveNeighbor++;
             }
            if (myboard[i+ 1][j]) {
             liveNeighbor++;
             }
            }


       if (i > 0) {
         if (myboard[i - 1][j + 1]) {
           liveNeighbor++;
         }
         if (myboard[i - 1][j - 1]) {
           liveNeighbor++;
         }
         if (myboard[i- 1][j]) {
           liveNeighbor++;
         }
       }

       //set cells to live or dead based on rules
       if(myboard[i][j]) {
         if(liveNeighbor === 2 || liveNeighbor === 3) {
           temboard[i][j] = true;
         }
       } else {
         if(liveNeighbor === 3) {
          temboard[i][j] = true;
         }
     }
   }
}
this.setState({currentboard:temboard});
setTimeout(this.updaterboard, 2000);
}


  render() {
    return (
        <div>
          <Board currentboard={this.state.currentboard}  makeCellLive={this.makeCellLive}/>
         </div>
    );
  }
}

export default App;
