import './assets/css/style.css';

import { BrowserRouter, Route, Routes } from 'react-router-dom';

import LoginForm from 'components/authorization/LoginForm';
import RegisterForm from 'components/authorization/RegisterForm';

function App() {
  return (
    <BrowserRouter>
      <div>
        <Routes>
          <Route path="/login" element={<LoginForm />} />
          <Route path="/register" element={<RegisterForm />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
