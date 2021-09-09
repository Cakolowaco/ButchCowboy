import React, { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [projects, setProjects] = useState([]);

    // Get projects from the API
  useEffect(() => {
    axios.get('http://localhost:5000/api/projects').then(response => {
      console.log(response);
      setProjects(response.data);
    })
  }, [])

  return (
    <div>
      <Header as='h2' icon='users' content='ButchCowboy' />
        <List>
          {projects.map((project: any) => (
            <List.Item key={project.id}>
              {project.title}
            </List.Item>
          ))}
        </List>
    </div>
  );
}

export default App;