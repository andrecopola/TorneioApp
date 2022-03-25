import React, { Component } from 'react';

export class ListarTorneios extends Component {
    static displayName = ListarTorneios.name;

    constructor(props) {
        super(props);
        this.state = { torneios: [], loading: true };
    }

    componentDidMount() {
        this.populateTorneioData();
    }

    static renderTorneiosTable(torneios) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>Data criação</th>
                        <th>Andamento</th>
                    </tr>
                </thead>
                <tbody>
                    {torneios.map(torneio =>
                        <tr key={torneio.id}>
                            <td>{torneio.nome}</td>
                            <td>{torneio.data}</td>
                            <td>{torneio.status}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Carregando torneios...</em></p>
            : ListarTorneios.renderTorneiosTable(this.state.torneios);

        return (
            <div>
                <h1 id="tabelLabel" >Torneios</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateTorneioData() {
        const response = await fetch('torneios');
        const data = await response.json();
        this.setState({ torneios: data, loading: false });
    }
}
