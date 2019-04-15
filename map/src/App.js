import React, { Component, PureComponent } from 'react';
import ReactDOM from 'react-dom';
import {  ScaleControl,
          ZoomControl,
          RotationControl } from "react-mapbox-gl";

import ReactMapboxGl, { Layer, Feature } from "react-mapbox-gl";
import { withStyles } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Typography from '@material-ui/core/Typography';
import Card from '@material-ui/core/Card';
import ExpansionPanel from '@material-ui/core/ExpansionPanel';
import ExpansionPanelSummary from '@material-ui/core/ExpansionPanelSummary';
import ExpansionPanelDetails from '@material-ui/core/ExpansionPanelDetails';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import FormControl from '@material-ui/core/FormControl';
import Select from '@material-ui/core/Select';
import InputLabel from '@material-ui/core/InputLabel';
import MenuItem from '@material-ui/core/MenuItem';
import TextField from '@material-ui/core/TextField';
import MomentUtils from '@date-io/moment';

import axios from 'axios';

import Button from '@material-ui/core/Button';
import logo from './logo.svg';
import './App.css';
import { forEach } from 'gl-matrix/src/gl-matrix/vec3';

const url = '40.113.148.40:5000'
const data = require('./heatmapData.json');
const data2 = require('./data-test.json');
const { token, mapStyles } = require('./config.json');

const Map = ReactMapboxGl({
  accessToken: "pk.eyJ1IjoiZGlhbmFkMyIsImEiOiJjam9qdTVpODUwOGQ2M2xwanBrcnNrczdoIn0.17CYLLGtE45Y3rkNkSCSSA"
});


const mapStyle = {
  flex: 1
};



const layerPaint = {
  'heatmap-weight': {
    property: 'name',
    type: 'exponential',
    stops: [[0, 0], [5, 2]]
  },
  // Increase the heatmap color weight weight by zoom level
  // heatmap-ntensity is a multiplier on top of heatmap-weight
  'heatmap-intensity': {
    stops: [[0, 0], [5, 1.2]]
  },
  // Color ramp for heatmap.  Domain is 0 (low) to 1 (high).
  // Begin color ramp at 0-stop with a 0-transparancy color
  // to create a blur-like effect.
  'heatmap-color': [
    'interpolate',
    ['linear'],
    ['heatmap-density'],
    0,
    'rgba(33,102,172,0)',
    0.25,
    'rgb(103,169,207)',
    0.5,
    'rgb(209,229,240)',
    0.8,
    'rgb(253,219,199)',
    1,
    'rgb(239,138,98)',
    2,
    'rgb(178,24,43)'
  ],
  // Adjust the heatmap radius by zoom level
  'heatmap-radius': {
    stops: [[0, 1], [5, 50]]
  }
};

const styles = theme => ({
  root: {
    flexGrow: 1,
    display: 'flex',
    flexWrap: 'wrap',
  },
  card: {
    position: 'absolute',
    top: 80,
    left: 40,
    maxWidth: 345,
  },
  media: {
    height: 140,
  },
  formControl: {
    margin: theme.spacing.unit,
    minWidth: 250,
  },
  button: {
    margin: theme.spacing.unit,
  },
  selectEmpty: {
    marginTop: theme.spacing.unit * 2,
  },
  textField: {
    marginLeft: theme.spacing.unit,
    marginRight: theme.spacing.unit,
    width: 250,
  },
});

class App extends PureComponent {

  

  constructor() {
    super();
    this.state = {
      selectedLayer: '',
      selectedStartDate: '2010-05-01',
      selectedEndDate: '2010-05-25',
      center:[25,45],
      layerData:null
    };
    this.handleLayerChange = this.handleLayerChange.bind(this);
    this.handleStartDateChange = this.handleStartDateChange.bind(this);
    this.handleEndDateChange = this.handleEndDateChange.bind(this);
    this.getData = this.getData.bind(this);
  }

  getData() {

    axios.get(`http://${url}/get/layer/time/${this.state.selectedLayer}/${this.state.selectedStartDate}/00:00:00/${this.state.selectedEndDate}/00:00:00`, {crossdomain: true })
      .then(res => {
        const response = res.data;
        this.setState({ layerData: response });
      })
  }

  componentDidMount() {
    axios.get(`http://${url}/get/layers`, {crossdomain: true })
      .then(res => {
        const response = res.data;
        this.setState({ layers: response.layers });
      })
  }
  renderListOfLayers() {
    return this.state.layers ? this.state.layers.map((layer, i) => {
      return (
        <MenuItem
          key={i}
          value={layer}>
          {layer}
        </MenuItem>
      );
    }) : [];
  }
  
  onStyleLoad = (map) => {
    const { onStyleLoad } = this.props;
    return onStyleLoad && onStyleLoad(map);
  }

  handleLayerChange = (event) => {
    this.setState({selectedLayer: event.target.value });
  };

  handleStartDateChange = (event) => {
    this.setState({ selectedStartDate: event.target.value });
  };
  handleEndDateChange = (event) => {
    this.setState({ selectedEndDate: event.target.value });
  };



  render() {
    const { classes } = this.props;
    return (
      
      <div className={classes.root}>
        <AppBar position="static" color="default" style={{backgroundColor:'#fff'}}>
          <Toolbar>
            <img alt="logo" src="./logo.png" style={{"height":"40px",width:"auto" }}/>
          </Toolbar>
        </AppBar>
        <Map style="mapbox://styles/mapbox/dark-v9"
          containerStyle={{
            height: "100vh",
            width: "100vw"
          }}
          showUserLocation={true}
          center={this.state.center}
          zoom={[1]}
          onStyleLoad={this.onStyleLoad}>
          <div style={{position: 'absolute', right: 0, top:0}}>
              <ScaleControl />
              <ZoomControl />
              <RotationControl style={{"top":80}} />
          </div>

        {this.state.layerData && <Layer type="heatmap" paint={layerPaint}>
            {this.state.layerData.features.map((el, index) => (
              <Feature key={index} coordinates={el.geometry.coordinates} properties={el.properties} />
            ))}
          </Layer>} 
        </Map>
        <Card className={classes.card}>
          <ExpansionPanel>
            <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
              <Typography variant="h6">ANALYSIS</Typography>
            </ExpansionPanelSummary>
            <ExpansionPanelDetails>
              <div>
              <Typography variant="body1" gutterBottom>
                Select Layer Data:
              </Typography>
              <FormControl className={classes.formControl}>
                <InputLabel htmlFor="layers">Layers</InputLabel>
                  <Select
                    value={this.state.selectedLayer}
                    onChange={this.handleLayerChange}
                    inputProps={{
                    name: 'layer',
                    id: 'layers',
                  }}>
                    <MenuItem value="">
                      <em>None</em>
                    </MenuItem>
                    {this.renderListOfLayers()}
                  </Select>
              </FormControl>
              <Typography variant="body1" gutterBottom style={{"marginTop":"40px"}}>
                Select Start Date:
              </Typography>
              <TextField
                id="date"
                type="date"
                value={this.state.selectedStartDate}
                onChange={this.handleStartDateChange}
                className={classes.textField}
                InputLabelProps={{
                  shrink: true,
                }}
                />
                
              
              <Typography variant="body1" gutterBottom style={{"marginTop":"40px"}}>
                Select End Date:
              </Typography>
              <TextField
                id="date"
                type="date"
                value={this.state.selectedEndDate}
                onChange={this.handleEndDateChange}
                className={classes.textField}
                InputLabelProps={{
                  shrink: true,
                }}
                />

                <Button variant="contained" color="primary" className={classes.button} onClick={this.getData}>
                RUN
              </Button>
                
              </div>
                
            </ExpansionPanelDetails>
          </ExpansionPanel>
        </Card>
      </div>
    );
  }
}

export default withStyles(styles) (App);
