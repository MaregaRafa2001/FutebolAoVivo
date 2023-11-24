import React from 'react';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import '../../sass/pages/Matchs/Match.sass'

const Match = ({ match }) => {
  return (
    <div className="match-card">
      <Router>

        <Link to={'/teams/team/' + match.time_mandante.time_id}>
          <img className="team-logo" src={match.time_mandante.escudo} title={match.time_mandante.nome_popular} />
          <span className="team-name">{match.time_mandante.sigla}</span>
        </Link>

        <div className="match-details">
          <p className="match-date">{match.data_realizacao}</p>
          <p className="match-status">{match.status}</p>
        </div>

        <Link to={'/teams/team/' + match.time_visitante.time_id}>
          <img className="team-logo" src={match.time_visitante.escudo} title={match.time_visitante.nome_popular} />
          <span className="team-name">{match.time_visitante.sigla}</span>
        </Link>

      </Router>
    </div>
  );
};

export default Match;
