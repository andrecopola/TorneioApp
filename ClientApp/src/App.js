import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { ListarJogadores } from './components/Jogadores';
import { Torneios} from './components/Torneios';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/Jogadores' component={ListarJogadores} />
            <Route path='/torneios' component={Torneios} />
      </Layout>
    );
  }
}
