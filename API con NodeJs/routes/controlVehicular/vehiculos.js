const express = require('express');
const vehiculos = express.Router();
const db = require('../../config/db');

// id
vehiculos.get('/id::id([0-9]{1})', async (req, res) => {
    const id = req.params.id;
    const result = await db.query(`SELECT * FROM vehiculos WHERE id = ${id};`);
    (id > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Vehicle not founf by ID");
});

// type
vehiculos.get('/type::type([A-Za-z]+)', async (req, res) => {
    const type = req.params.type;
    console.log(type);
    const result = await db.query(`SELECT * FROM vehiculos WHERE tipo = '${type}';`);
    (type.length > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Vehicle not found");
});

// marca
vehiculos.get('/marca::marca([A-Za-z]+)', async (req, res) => {
    const marca = req.params.marca;
    const result = await db.query(`SELECT * FROM vehiculos WHERE marca = '${marca}';`);
    (marca.length > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Vehicle not found");
});

// model
vehiculos.get('/model::model([0-9]{4})', async (req, res) => {
    const model = req.params.model;
    const result = await db.query(`SELECT * FROM vehiculos WHERE modelo = ${model}`);
    (model.length == 4 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Vehicle not found");
});

// type of fuel
vehiculos.get('/typeF::typeF([A-Za-z]+)', async (req, res) => {
    const typeFuel = req.params.typeF;
    const result = await db.query(`SELECT * FROM vehiculos WHERE tipo_combustible = '${typeFuel}';`);
    (typeFuel.length > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Vehicle not found");
});

module.exports = vehiculos;