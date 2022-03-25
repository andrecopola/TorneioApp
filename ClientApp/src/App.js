import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { ListarJogadores } from './Pages/Jogadores/Index';
import { ListarTorneios } from './Pages/Torneios/Index';
import { ListarPartidas } from './Pages/Partidas/Index';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/Jogadores' component={ListarJogadores} />
            <Route path='/Torneios' component={ListarTorneios} />
            <Route path='/Partidas' component={ListarPartidas} />
      </Layout>
    );
  }
}
