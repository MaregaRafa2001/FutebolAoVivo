import React, { useState } from "react";
import Matchs from "../Matchs/Matchs";
import { getChampionshipMatchs } from '../../integrators/api-futebol.com.br/ApiFutebolService';

const League = ({ league }) => {
    const [fetchedMatchs, setFetchedMatchs] = useState([]); // Initialize with an empty array

    const handleClickFetchMatchs = async () => {
        try {
            const data = await getChampionshipMatchs(league.campeonato_id); // Fetch data based on the league ID

            const group1Matches = Object.values(data.partidas['partidas']['primeira-fase']['chave-1']);
            const group2Matches = Object.values(data.partidas['partidas']['primeira-fase']['chave-2']);
            const concatenatedMatches = [...group1Matches, ...group2Matches];

            setFetchedMatchs(concatenatedMatches);
            debugger;
        } catch (error) {
            console.error('Erro ao buscar dados.');
        }
    };

    return (
        <div key={league.campeonato_id} onClick={handleClickFetchMatchs}>
            <img className="league-logo" src={league.logo} alt="Team Logo" />
            <span className="league-name">{league.nome}</span>
            <Matchs matchs={fetchedMatchs} />
        </div>
    );
};

export default League;
