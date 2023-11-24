import axios from 'axios';

const api = axios.create({
  baseURL: 'http://localhost:5082/api',
});

const fetchData = async (endpoint) => {
  try {
    const response = await api.get(endpoint);
    return JSON.parse(response.data);
  } catch (error) {
    console.error('Erro ao buscar dados:', error);
    return [];
  }
};

const ApiEndpoints = {
  getChampionships: '/campeonatos',
  getChampionship: '/campeonatos/{campeonato_id}',
  getChampionshipTable: '/campeonatos/{campeonato_id}/tabela',
  getChampionshipTopScorers: '/campeonatos/{campeonato_id}/artilharia',
  getChampionshipPhases: '/campeonatos/{campeonato_id}/fases',
  getChampionshipPhase: '/campeonatos/{campeonato_id}/fases/{fase_id}',
  getChampionshipRounds: '/campeonatos/{campeonato_id}/rodadas',
  getChampionshipRound: '/campeonatos/{campeonato_id}/rodadas/{rodada}',
  getLiveMatchs: '/ao-vivo',
  getChampionshipMatchs: '/campeonatos/{campeonato_id}/partidas',
  getChampionshipMatch: '/campeonatos/{campeonato_id}/partidas/{partida_id}'
};

export const getChampionships = async () => {
    return fetchData(ApiEndpoints.getChampionships);
};

export const getChampionship = async (campeonato_id) => {
  return fetchData(ApiEndpoints.getChampionship.replace('{campeonato_id}', campeonato_id));
};

export const getChampionshipTable = async (campeonato_id) => {
  return fetchData(ApiEndpoints.getChampionshipTable.replace('{campeonato_id}', campeonato_id));
};

export const getChampionshipTopScorers = async (campeonato_id) => {
  return fetchData(ApiEndpoints.getChampionshipTopScorers.replace('{campeonato_id}', campeonato_id));
};

export const getChampionshipPhases = async (campeonato_id) => {
  return fetchData(ApiEndpoints.getChampionshipPhases.replace('{campeonato_id}', campeonato_id));
};

export const getChampionshipPhase = async (campeonato_id, fase_id) => {
  return fetchData(ApiEndpoints.getChampionshipPhase.replace('{campeonato_id}', campeonato_id).replace('{fase_id}', fase_id));
};

export const getChampionshipRounds = async (campeonato_id) => {
  return fetchData(ApiEndpoints.getChampionshipRounds.replace('{campeonato_id}', campeonato_id));
};

export const getChampionshipRound = async (campeonato_id, rodada) => {
  return fetchData(ApiEndpoints.getChampionshipRound.replace('{campeonato_id}', campeonato_id).replace('{rodada}', rodada));
};

export const getLiveMatchs = async () => {
    return fetchData(ApiEndpoints.getLiveMatchs);
};

export const getChampionshipMatchs = async (campeonato_id) => {
    return fetchData(ApiEndpoints.getChampionshipMatchs.replace('{campeonato_id}', campeonato_id));
};

export const getChampionshipMatch = async (campeonato_id, partida_id) => {
    return fetchData(ApiEndpoints.getChampionshipMatch.replace('{campeonato_id}', campeonato_id).replace('{partida_id}', partida_id));
};