import React from 'react';
import ReactDOM from 'react-dom';
import components from "./components/index"
import ReactDOMServer from 'react-dom/server';
// import InitialTestBlock from "./components/InitialTest/index"

global.React = React;
global.ReactDOM = ReactDOM;
global.ReactDOMServer = ReactDOMServer;

// Make all components globally available.
global.Components = components;