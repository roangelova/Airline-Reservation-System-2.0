import './assets/css/style.css';

import { BrowserRouter, Route, Routes } from 'react-router-dom';

import LoginForm from 'components/authorization/LoginForm';
import RegisterForm from 'components/authorization/RegisterForm';
import Hero from 'components/common/Hero';
import AdminLayout from 'components/admin/AdminLayout'


function App() {
  return (
    <BrowserRouter >
        <Routes>
          <Route path="/login" element={<LoginForm />} />
          <Route path="/register" element={<RegisterForm />} />
        </Routes>
    </BrowserRouter>
  );
}

export default App;
