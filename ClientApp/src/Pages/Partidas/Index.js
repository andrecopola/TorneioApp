import React, { Component } from 'react';

export class ListarPartidas extends Component {
    static displayName = ListarPartidas.name;

    constructor(props) {
        super(props);
        this.state = { partidas: [], loading: true };
    }

    componentDidMount() {   
        this.populatePartidaData();
    }

    static renderPartidasTable(Partidas) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Torneio</th>
                        <th>Partida</th>
                        <th>Jogador Brancas</th>
                        <th>Jogador Negras</th>
                        <th>Resultado</th>
                    </tr>
                </thead>
                <tbody>
                    {Partidas.map(partida =>
                        <tr key={partida.id}>
                            <td>{partida.nomeTorneio}</td>
                            <td>{partida.numero}</td>
                            <td>{partida.nomeJogadorBrancas}</td>
                            <td>{partida.nomeJogadorNegras}</td>                            
                            <td>{partida.resultadoPartida}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Carregando Partidas...</em></p>
            : ListarPartidas.renderPartidasTable(this.state.partidas);

        return (
            <div>
                <h1 id="tabelLabel" >Partidas</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populatePartidaData() {
        const response = await fetch('partidas');
        const data = await response.json();
        this.setState({ partidas: data, loading: false });
    }
}
