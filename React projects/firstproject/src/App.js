import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import CardList from './CardList'
import getData from './getData'



class App extends Component {
  constructor(props){
    super(props);

    this.state={
      cardData: getData(),
      currentTitle: "",
      currentText: "",
      currentId: 6,
    }
    this.addCard = this.addCard.bind(this);
    this.changeTitle = this.changeTitle.bind(this);
    this.changeText = this.changeText.bind(this);
    this.changeColor = this.changeColor.bind(this);
    this.deleteCard = this.deleteCard.bind(this);
  }

  addCard(){
    let temArray = this.state.cardData
    temArray.push({title:this.state.currentTitle,
                   text:this.state.currentText,
                    id:this.state.currentId,
                     color:"blue"});
    this.setState({
      cardData:temArray,
      currentId:this.state.currentId +1,
      currentTitle:"",
      currentText:"",
    });
  }
  changeTitle(event) {
      this.setState({
        currentTitle: event.target.value,
      })
    }

    changeText(event) {
      this.setState({
        currentText: event.target.value,
      })
    }

    changeColor(id) {
      const tempArray = this.state.cardData;
      for(let i = 0; i < tempArray.length; i++)
      {
        if (tempArray[i].id === id)
        {
          if(tempArray[i].color === "red")
          {
            tempArray[i].color = "blue";
          }
          else
          {
            tempArray[i].color = "red";
          }
        }
      }
      this.setState({
        cardData: tempArray,
      })
    }

deleteCard(id)
{
const tempArray = this.state.cardData;
let deleteme = -1;
for(let i = 0; i < tempArray.length; i++)
{
  if (tempArray[i].id === id)
  {
    deleteme = i;
  }
}
tempArray.splice(deleteme, 1);
this.setState({
  cardData: tempArray,
})
}

  render() {
    return (
      <div className="App">
        <div className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h2>Welcome to React Rabia</h2>
        </div>
        <div>
        <input value={this.state.currentTitle} onChange={this.changeTitle} />
        <input value={this.state.currentText} onChange={this.changeText} />
        <input type="submit" value="Add Card!" onClick={this.addCard} />
        </div>
        <CardList cardData={this.state.cardData} changeColor={this.changeColor} deleteCard={this.deleteCard}/>pm
      </div>
    );
  }
}

export default App;
