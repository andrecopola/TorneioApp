import React, { Component } from 'react';

export class ListarJogadores extends Component {
  static displayName = ListarJogadores.name;

  constructor(props) {
    super(props);
    this.state = { jogadores: [], loading: true };
  }

  componentDidMount() {
    this.populateJogadorData();
  }

    static renderJogadoresTable(jogadores) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Nome</th>
            <th>Perfil Chess.com</th>
          </tr>
        </thead>
        <tbody>
            {jogadores.map(jogador =>
                <tr key={jogador.id}>
                    <td>{jogador.nome}</td>
                    <td>{jogador.perfilChessCom}</td>
                </tr>
            )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
        ? <p><em>Carregando jogadores...</em></p>
        : ListarJogadores.renderJogadoresTable(this.state.jogadores);

    return (
      <div>
        <h1 id="tabelLabel" >Jogadores</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateJogadorData() {
    const response = await fetch('jogadores');
      const data = await response.json();
      this.setState({ jogadores: data, loading: false });
  }
}
