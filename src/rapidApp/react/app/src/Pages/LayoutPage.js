/*  Core Modules  */
import React from 'react';

/*  Stylesheets  */
import 'antd/dist/antd.css';
import './LayoutPage.css';

/*  Ant.Design Components  */
import { Layout, Space, Menu, Breadcrumb } from 'antd';

/*  Containers  */
import Grid from '../Containers/Grid';

const { Header, Content, Footer } = Layout;

function LayoutPage() {
    return (
        <Layout className="layout">
            <Header style={{ position: 'fixed', zIndex: 1, width: '100%' }}>
                <div className="logo" />
                
                <Menu theme="dark" mode="horizontal" defaultSelectedKeys={['2']}>
                    <Menu.Item key="1">nav 1</Menu.Item>
                    <Menu.Item key="2">nav 2</Menu.Item>
                    <Menu.Item key="3">nav 3</Menu.Item>
                </Menu>
            </Header>
            <Content style={{ padding: '0 50px', marginTop: '64px' }}>
                <Breadcrumb style={{ margin: '16px 0' }}>
                    <Breadcrumb.Item>Home</Breadcrumb.Item>
                    <Breadcrumb.Item>List</Breadcrumb.Item>
                    <Breadcrumb.Item>App</Breadcrumb.Item>
                </Breadcrumb>
                <div className={'site-layout-background'} style={{ padding: 24, minHeight: 380 }}>
                    <Grid />
                </div>
            </Content>
            <Footer style={{ textAlign: 'center' }}>
                Ant Design ©2018 Created by Ant UED
            </Footer>
        </Layout>
    );
}

export default LayoutPage;