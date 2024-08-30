import logo from './logo.svg';
import './App.css';

function App() {
  

  var x=100;
  var y=200;
  return (
    <div className="container">
      <div className='border border-warning p-5 m-5 w-75 bg-info text-danger'>
      <div>
        <h1>Welcome to react application</h1>
        <img src={logo} width='200' height='150'></img>
        <div>
          No 1 is {x}
        </div>
        <div>
          No 2 is {y}
        </div>
        <div>
          sum of {x} and {y} is {x+y}
        </div>
      </div>
    </div>
    </div>
  );
}

export default App;
