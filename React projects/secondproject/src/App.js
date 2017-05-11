import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import CardList from './CardList';
import getData from './getData';

class App extends Component {
        constructor(props){
         super(props);

         this.state={
           myCards: getData(),
           currentText: "",
           currentId: 10,
           currntFlib:false,

         }
this.flibCard = this.flibCard.bind(this);
        }

        flibCard(id) {
          const tempArray = this.state.myCards;
          //let deleteme = -1;
          for(let i = 0; i < tempArray.length; i++)
          {

            if (tempArray[i].id === id)
            {
              if(tempArray[i].flib == false)
              {
                tempArray[i].flib=true;
              }
              else
              {
                tempArray[i].flib=false;
              }
            }
          }
          this.setState({
            myCards:tempArray,
          })
        }

  render() {
    return (
      <div className="App">
        <div className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h2>Welcome to My First Game In React!!</h2>
          <h2>GLICK TO FLib!</h2>
        </div>
        <div className="Rabia">
         <CardList myCards={this.state.myCards} flibCard={this.flibCard}/>
         </div>
      </div>
    );
  }
}

export default App;
