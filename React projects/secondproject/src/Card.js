import React,{Component} from 'react'

class Card extends Component{
  constructor(props){
   super(props);
   this.showText = this.showText.bind(this);
   }


  showText()
  { if (this.props.item.flib === true)
     {return this.props.item.text;}
    else
    {return "Click To Flip!!";}
  }





render(){
  return(
    <div className="card" onClick={() => {this.props.flibCard(this.props.item.id)}}>
    <b> {this.showText()}</b>
    </div>
  )
}
};
export default Card;
