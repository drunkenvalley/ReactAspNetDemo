import React from 'react'
import ReactDOM from 'react-dom'
import ReactDOMServer from 'react-dom/server'

import TestComponent from './components/test.jsx'

global.React = React
global.ReactDOM = ReactDOM
global.ReactDOMServer = ReactDOMServer

global.Components = { TestComponent }