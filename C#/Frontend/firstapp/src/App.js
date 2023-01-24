import logo from './logo.svg';
import './App.css';
import Header from './components/Header';
import ProductList from './components/ProductList';

function App() {
  return (
    <div className="App">
      <Header></Header>
      <ProductList></ProductList>
      <EmployeeList></EmployeeList>

    </div>
  );
}

export default App;
