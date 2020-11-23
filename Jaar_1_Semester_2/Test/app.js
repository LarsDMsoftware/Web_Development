const express = require('express');
const Pokedex = require('pokedex');
const pokedex = new Pokedex();
const ejs = require('ejs');

const app = express();
const addressJSON = require('./address.json')

app.set('view engine', 'ejs');
app.set('port', process.env.PORT || 3000);


app.get('/', (req,res) =>{
    res.type('text/html');
    res.render('index.ejs');
});


app.get('/address', (req,res) =>{
    res.render('address',{'straat':addressJSON.straat, 'city':addressJSON.city});
});

let pokemonNames = [];
let pokemonWeights = [];

for(let i=1; i< 11; i++)
{
  const pokemon = pokedex.pokemon(i);
  const pokemonName = pokemon.name;
  const pokemonWeight = pokemon.weight;
  pokemonNames.push(pokemonName);
  pokemonWeights.push(pokemonWeight);
}
app.get('/pokemon', (req,res) =>
{
  res.type('text/html');
  res.render('pokemon.ejs');
});

app.listen(app.get('port'), function(){
  console.log( 'Express started on http://localhost:' + app.get('port') + '; press Ctrl-C to terminate.');
  });
