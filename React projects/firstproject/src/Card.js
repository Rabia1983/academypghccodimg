import React, { Component } from 'react';

class Card extends Component {
  render() {
    return (
        <div className={"card " +this.props.hotdog.color} onClick={()=>{this.props.changeColor(this.props.hotdog.id)}}>
        <span className="zar" onClick={()=>{this.props.deleteCard(this.props.hotdog.id)}}> X </span>
        <h1>{this.props.hotdog.title}</h1>
        <p>{this.props.hotdog.text}</p>
        <p>{this.props.hotdog.id}</p>
        </div>
    );
  }
}

export default Card;
