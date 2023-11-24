import React, { useState } from 'react';
import League from '../Leagues/League';
const Leagues = ({ leagues }) => {
    
    return (
        <div>
            {leagues.map((league) => (
                <League key={league.campeonato_id} league={league} />
            ))}
        </div>
    );
};

export default Leagues;
