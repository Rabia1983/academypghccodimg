import React ,{Component} from 'react'
import Cell from './cell'

class Board extends Component {
  render() {
    var grid=[];
var anotherboard=this.props.currentboard;
for (var i =0;i<anotherboard.length;i++){
  for(var j=0;j<anotherboard.length;j++){
     grid.push(
       <Cell
       isAlive={anotherboard[i][j]}
          key={i + " " + j}
          rowNumber={i}
          cellNumber={j}
          makeCellLive={this.props.makeCellLive}
       />
     )
    }
    grid.push(<br key={i}/>);
    }

    return (
    <div>
      {grid}
    </div>
      )
}
}
export default Board;
