import React from 'react'
import './assets/css/style.css';
import Header from './components/shared/Header';
import Hero from 'components/common/Hero';
import AdminLayout from 'components/admin/AdminLayout';
import LoginForm from 'components/authorization/LoginForm';

function App() {
  return (
    <div>
     <LoginForm/>
    </div>
  );
}

export default App;
