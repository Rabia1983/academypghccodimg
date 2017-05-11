import React ,{Component} from 'react'


class Cell extends Component {

    lifeclass(){
      return this.props.isAlive ? "live":"dead";
    }
    render() {
    return (
    <span className={this.lifeclass()} onClick={()=>{this.props.makeCellLive(this.props.rowNumber, this.props.cellNumber)}}/>
);
}
}
export default Cell;
