const express = require('express');
const conductores = express.Router();
const db = require("../../config/db");

conductores.get('/:idConduc([0-9]{1})', async (req, res) => {
    const idConduc = req.params.idConduc;
    const result = await db.query(`SELECT * FROM conductores WHERE id = ${idConduc};`);    
    (idConduc > 0 && idConduc < 3) ?
        res.status(200).send(result) :
        res.status(404).send("Driver Not Found"); 
});

//Name
conductores.get('/name::name([A-Za-z]+)', async (req, res) => {
    const name = req.params.name;
    const result = await db.query(`SELECT * FROM conductores WHERE nombre = '${name}';`);
    (name.length > 0 && result.length > 0) ?     
        res.status(200).send(result) :
        res.status(404).send("Driver Not Found o not available at this time"); 
});


//Gender
conductores.get('/gender::gender(M|F|m|f)', async (req, res) => {
    const gender = req.params.gender.toUpperCase();
    const result = await db.query(`SELECT * FROM conductores WHERE sexo = '${gender}';`);
    (gender.length == 1 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Drivers by gender Not Found o not available at this time");
});

module.exports = conductores;