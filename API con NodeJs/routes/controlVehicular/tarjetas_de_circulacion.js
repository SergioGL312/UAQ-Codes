const express = require('express');
const trjtsCirc = express.Router();
const db = require('../../config/db');

//registration card id
trjtsCirc.get('/idCard::idCard([0-9]{1})', async (req, res) => {
    const idCard = req.params.idCard;
    const result = await db.query(`SELECT * FROM tarjetas_circulacion WHERE id = ${idCard};`);
    (idCard > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Registration card id not found");
});

// owner id
trjtsCirc.get('/idOwner::idOwner([0-9]{1})', async (req, res) => {
    const idOwner = req.params.idOwner;
    const result = await db.query(`SELECT * FROM tarjetas_circulacion WHERE id_propietario = ${idOwner};`);
    (idOwner > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Registration card by owner id not found");
});

// vehicle id
trjtsCirc.get('/idVec::idVec([0-9]{1})', async (req, res) => {
    const idVec = req.params.idVec;
    const result = await db.query(`SELECT * FROM tarjetas_circulacion WHERE id_vehiculo = ${idVec};`);
    (idVec > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Registration card by vehicle id not found");
});

// plate
trjtsCirc.get('/plate::plate([A-Za-z0-9]+)', async (req, res) => {
    const plate = req.params.plate;
    const result = await db.query(`SELECT * FROM tarjetas_circulacion WHERE placa = '${plate}';`);
    (plate.length > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Registration card by plate not found");
});

module.exports = trjtsCirc;