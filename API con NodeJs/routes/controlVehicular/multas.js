const express = require('express');
const multas = express.Router();
const db = require('../../config/db');

//Folio
multas.get('/folio::folio([0-9]{1})', async (req, res) => {
    const folio = req.params.folio;
    const result = await db.query(`SELECT * FROM multas WHERE folio = ${folio};`);
    (folio.length > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Fine not found");
});

//vehicle id
multas.get('/idVec::idVec([0-9]{1})', async (req, res) => {
    const idVehcile = req.params.idVec;
    const result = await db.query(`SELECT * FROM multas WHERE id_vehiculo = ${idVehcile};`);
    (idVehcile.length > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Fine not found by Vehicle id");
});

//license id
multas.get('/idLic::idLic([0-9]{1})', async (req, res) => {
    const idLicense = req.params.idLic;
    const result = await db.query(`SELECT * FROM multas WHERE id_licencia = ${idLicense};`);
    (idLicense.length > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Fine not found by License id");
});

//registration card id
multas.get('/idRegC::idRegC([0-9]{1})', async (req, res) => {
    const idRegisCrd = req.params.idRegC;
    const result = await db.query(`SELECT * FROM multas WHERE id_tarjeta_circulacion = ${idRegisCrd};`);
    (idRegisCrd.length > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Fine not found by Registration card id");
});

module.exports = multas;