const express = require('express');
const verificaciones = express.Router();
const db = require('../../config/db');

// id
verificaciones.get('/id::id([0-9]{1})', async (req, res) => {
    const id = req.params.id;
    const result = await db.query(`SELECT * FROM verificaciones WHERE id = ${id};`);
    (id > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Not found")
});

// registration card id
verificaciones.get('/verify::verify([0-9]{1})', async (req, res) => {
    const id = req.params.verify;
    const result = await db.query(`SELECT * FROM verificaciones WHERE id_tarjeta_circulacion = '${id}';`);
    (id > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Not found");
});

module.exports = verificaciones;