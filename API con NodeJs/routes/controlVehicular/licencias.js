const express = require('express');
const licencias = express.Router();
const db = require('../../config/db');

licencias.get('/:idLic([0-9]{1})', async (req, res) => {
    const idLic = req.params.idLic;
    const result = await db.query(`SELECT * FROM licencias WHERE id = ${idLic};`);
    (idLic > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Driving license not found");
});

//Type license
licencias.get('/:type(A|a|B|b|C|c|D|d|E|e|F|f)', async (req, res) => {
    const tipo = req.params.type.toUpperCase();
    const result = await db.query(`SELECT * FROM licencias WHERE tipo = '${tipo}';`);
    (result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Driving license not found by type");
});


module.exports = licencias;