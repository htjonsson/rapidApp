/*  Core Modules  */
import React from 'react';
import { createRoot } from 'react-dom/client';

/*  Stylesheets  */
import 'antd/dist/antd.css';
import './index.css';

/*  Pages  */
import LayoutPage from './Pages/LayoutPage';

/*  Other  */
import reportWebVitals from './reportWebVitals';
/* */

const container = document.getElementById('root');
const root = createRoot(container);
root.render(
  <React.StrictMode>
    <LayoutPage />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
