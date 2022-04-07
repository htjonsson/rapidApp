/*  Core Modules  */
import React from 'react';
import { createRoot } from 'react-dom/client';

/*  Stylesheets  */
import 'antd/dist/antd.css';
import './index.css';

/*  Ant.Design Components  */
import { Layout } from 'antd';
import { Content } from 'antd/lib/layout/layout'; 

/*  Containers  */
import List from './Containers/List/List';
import Grid from './Containers/Grid/Grid';

/*  Other  */
import reportWebVitals from './reportWebVitals';
/* */

const container = document.getElementById('root');
const root = createRoot(container);
root.render(
  <React.StrictMode>
    <Layout className="layout">
      <Content style={{ padding: '0 50px' }}>
        <List />
        <Grid />
      </Content>
    </Layout>
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
