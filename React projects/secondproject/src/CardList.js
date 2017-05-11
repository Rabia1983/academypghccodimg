import React,{Component} from 'react';
import Card from './Card';

class CardList extends Component{
  render() {
    return(
      <div>
       {this.props.myCards.map((item,index)=> {
         return <Card item={item} key={index} flibCard={this.props.flibCard}/>
       })
     }
      </div>
    )
  }
}
export default CardList;
