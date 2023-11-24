import React from 'react';
import { useParams } from 'react-router-dom';

function Team() {
  const { id } = useParams();

  return <div>time: {id}</div>;
}

export default Team;
