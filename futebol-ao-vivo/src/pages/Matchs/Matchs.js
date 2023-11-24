import React, { useDebugValue } from 'react';
import Match from '../Matchs/Match'

const Matchs = ({ matchs }) => {
    return (
        <div>
            {matchs != undefined && (
                matchs.map((match) => (
                    <Match key={match.partida_id} match={match} />
                ))
            ) 
            }
        </div>
    )
};

export default Matchs;