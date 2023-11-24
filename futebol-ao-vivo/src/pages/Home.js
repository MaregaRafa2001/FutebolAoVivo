import React, { useState, useEffect } from 'react';
import { getLiveMatchs, getChampionships, getChampionshipMatchs } from '../integrators/api-futebol.com.br/ApiFutebolService';
import LiveScore from './Matchs/LiveScores';
import Leagues from './Leagues/Leagues';

function Home() {
    const [championships, setChampionships] = useState([]);
    const [selectedChampionshipId, setSelectedChampionshipId] = useState('');
    const [liveMatchs, setLiveMatchs] = useState([]);

    useEffect(() => {
        async function fetchLiveMatchs() {
            const data = await getLiveMatchs();
            setLiveMatchs(data);
        }
        fetchLiveMatchs();

        async function fetchChampionships() {
            const data = await getChampionships();
            setChampionships(data);
        }
        fetchChampionships();
    }, []);

    return (
        <div>
            <h1>PARTIDAS AO VIVO</h1>
            {liveMatchs.map((match) =>
                <LiveScore
                    key={match.partida_id}
                    match={match}
                />
            )}

            <h1>Escolha um campeonato:</h1>
            <Leagues leagues={championships} />
        </div>
    );
}

export default Home;
