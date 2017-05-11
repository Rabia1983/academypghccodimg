import React, { Component } from 'react';
import Card from './Card'

class CardList extends Component {
  render() {
    return (
  <div>
        {
          this.props.cardData.map((item,index) => {
            return <Card hotdog={item} key={index} deleteCard={this.props.deleteCard} changeColor={this.props.changeColor}/>
          })
        }
    </div>
    );
  }
}

export default CardList;
