/*  Core Modules  */
import React from 'react';

/*  Ant.Design Components  */
import { DatePicker, Space } from 'antd';

class List extends React.Component {
  render = () => {
    return (
      <React.Component>
        <Space direction="vertical">
          <DatePicker />
          <span>Class extends React.Fragment (arrow function)</span>
        </Space>
      </React.Component>
    );
  }
}

export default List;
