import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';

const myFirstElement = <h1><App /></h1>

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(myFirstElement);

