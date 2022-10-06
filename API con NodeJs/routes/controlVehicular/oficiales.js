const express = require('express');
const oficiales = express.Router();
const db = require('../../config/db');

// id
oficiales.get('/id::id([0-9]{1})', async (req, res) => {
    const id = req.params.id;
    const result = await db.query(`SELECT * FROM oficiales WHERE id = '${id}';`);
    (id > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Officer not found");
});

//Group
oficiales.get('/group::group([0-9]{1,3})', async (req, res) => {
    const group = req.params.group;
    console.log(group);
    const result = await db.query(`SELECT * FROM oficiales WHERE grupo = ${group};`);
    console.log(result);
    (group > 0 && result.length > 0) ?
        res.status(200).send(result) :
        res.status(404).send("Group not found");
});

module.exports = oficiales;