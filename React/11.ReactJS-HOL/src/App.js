import './App.css';
import { useState } from 'react';

function App() {

  const [count, setCount] = useState(5);

  const increment = () => {
    setCount(count + 1);
  };

  const decrement = () => {
    setCount(count - 1);
  };

  const sayHello = () => {
    alert("Hello! Member");
  };

  const incrementAndHello = () => {
    increment();
    sayHello();
  };

  const welcome = (msg) => {
    alert(msg);
  };

  const onPress = () => {
    alert("I was clicked");
  };

  const [amount, setAmount] = useState("");
  const [currency, setCurrency] = useState("");

  const handleSubmit = (e) => {

    e.preventDefault();

    if (currency.toLowerCase() === "euro") {

      const result = amount * 80;

      alert(`Converting to Euro Amount is ${result}`);

    } else {

      alert("Enter Currency as Euro");

    }
  };

  return (

    <div style={{ marginLeft: "50px" }}>

      <h3>{count}</h3>

      <button onClick={incrementAndHello}>
        Increment
      </button>

      <br /><br />

      <button onClick={decrement}>
        Decrement
      </button>

      <br /><br />

      <button onClick={() => welcome("Welcome")}>
        Say welcome
      </button>

      <br /><br />

      <button onClick={onPress}>
        Click on me
      </button>

      <br /><br />

      <h1 style={{ color: "green" }}>
        Currency Convertor!!!
      </h1>

      <form onSubmit={handleSubmit}>

        <label>Amount: </label>

        <input
          type="number"
          value={amount}
          onChange={(e) => setAmount(e.target.value)}
        />

        <br /><br />

        <label>Currency: </label>

        <input
          type="text"
          value={currency}
          onChange={(e) => setCurrency(e.target.value)}
        />

        <br /><br />

        <button type="submit">
          Submit
        </button>

      </form>

    </div>

  );

}

export default App;