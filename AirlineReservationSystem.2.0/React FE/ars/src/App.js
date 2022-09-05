import './assets/css/App.css';
import RegisterForm from './components/authorization/RegisterForm';
import Header from './components/shared/Header';

function App() {
  return (
    <div className="App">
      <Header />
      <div className='container'>
          <RegisterForm/>    
      </div>
      
    </div>
  );
}

export default App;
