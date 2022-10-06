const express = require('express');
const propietarios = express.Router();
const db = require('../../config/db');

// id
propietarios.get('/id::id([0-9]{1})', async (req, res) => {
    const id = req.params.id;
    const result = await db.query(`SELECT * FROM propietarios WHERE id = ${id};`);
    (id > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Owner not found");
});

// name
propietarios.get('/name::name([A-Za-z]+)', async (req, res) => {
    const name = req.params.name;
    const result = await db.query(`SELECT * FROM propietarios WHERE nombre = '${name}';`);
    (name.length > 0 && result.length > 0) ? 
        res.status(200).send(result) :
        res.status(404).send("Owner not found by name");
});

module.exports = propietarios;