/*  Core Modules  */
import React from 'react';

/* CSS */
import styles from './Grid.css';

/*  Ant.Design Components  */
import { Modal, message, Table, Tag, Space } from 'antd';
import { ExclamationCircleOutlined } from '@ant-design/icons';

const { Column } = Table;

class Grid extends React.Component {
  data = [];

  onLoad = () => {
    this.data = [
      {
        key: '1',
        firstName: 'John',
        lastName: 'Brown',
        age: 32,
        address: 'New York No. 1 Lake Park',
        tags: ['nice', 'developer'],
      },
      {
        key: '2',
        firstName: 'Jim',
        lastName: 'Green',
        age: 42,
        address: 'London No. 1 Lake Park',
        tags: ['loser'],
      },
      {
        key: '3',
        firstName: 'Joe',
        lastName: 'Black',
        age: 32,
        address: 'Sidney No. 1 Lake Park',
        tags: ['cool', 'teacher'],
      },
    ];
  }

  onInvite = (record) => {
    alert('Invite');
  };

  onDelete = (record) => {
    /* https://stackoverflow.com/questions/57379945/trying-to-flip-the-position-of-the-ok-and-cancel-buttons-inside-an-antd-modal-us/57381358#57381358 */
    Modal.confirm({
      title: 'Confirm',
      icon: <ExclamationCircleOutlined />,
      content: 'Do you want to delete recrod',
      okText: 'OK',
      cancelText: 'Cancel',
      okButtonProps: {
        type: 'default'
      },
      cancelButtonProps: {
        type: 'primary'
      },
      onOk() {
        message.info('Record deleted ' + record.key)
        console.log('onOK');
      },
      onCancel() {
        console.log('onCancel');
      }
    });
  };

  render = () => {
    this.onLoad();

    return (
      <Table className={styles.custom} dataSource={this.data}>
        <Column title="First Name" dataIndex="firstName" key="firstName" />
        <Column title="Last Name" dataIndex="lastName" key="lastName" />
        <Column title="Age" dataIndex="age" key="age" />
        <Column title="Address" dataIndex="address" key="address" />
        <Column
          title="Tags"
          dataIndex="tags"
          key="tags"
          render={tags => (
            <>
              {tags.map(tag => (
                <Tag color="blue" key={tag}>
                  {tag}
                </Tag>
              ))}
            </>
          )}
        />
        <Column
          title="Action"
          key="action"
          render={(text, record) => (
            <Space size="middle">
              <a onClick={() => this.onInvite(record)}>Invite {record.lastName}</a>
              <a onClick={() => this.onDelete(record)}>Delete</a>
            </Space>
          )}
        />
      </Table>
    );
  }
}

export default Grid;
