import './App.css';
import office from "./office.png";
function App() {

  const officeSpaces = [

    {
      Name: "DBS",
      Rent: 50000,
      Address: "Chennai",
      Image: office
    },

    {
      Name: "Regus",
      Rent: 75000,
      Address: "Bangalore",
      Image: office
    },

    {
      Name: "SmartWorks",
      Rent: 55000,
      Address: "Hyderabad",
      Image: office
    }

  ];

  return (

    <div style={{ marginLeft: "80px" }}>

      <h1>Office Space , at Affordable Range</h1>

      {
        officeSpaces.map((item, index) => (

          <div key={index} style={{ marginBottom: "40px" }}>

            <img
              src={item.Image}
              width="250"
              height="200"
              alt="Office Space"
            />

            <h2>Name: {item.Name}</h2>

            <h3
              style={{
                color: item.Rent < 60000 ? "red" : "green"
              }}
            >
              Rent: Rs. {item.Rent}
            </h3>

            <h3>Address: {item.Address}</h3>

          </div>

        ))
      }

    </div>

  );

}

export default App;