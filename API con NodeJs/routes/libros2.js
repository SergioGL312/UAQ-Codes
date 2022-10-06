const express = require('express');
const libro = express.Router();
const librosJson = require('../json/libros2.json');

libro.get('/all', (req, res) => {
    res.status(200).send(librosJson);
});

libro.get('/:id([0-9]{1,3})', (req, res) => {
    const id = req.params.id;
    if (id >= 1 && id <= 140) {
        res.status(200)
        return res.send(librosJson[id - 1]);
    }
    res.status(404);
    res.send("User Not Found");
});

libro.get('/:title([A-Za-z]+)', (req, res) => {
    const title = req.params.title;
    const t = librosJson.filter((x) => {
        return (x.titulo.toUpperCase() === title.toUpperCase()) ?
                x : null;
    });
    
    (t.length > 0) ?
        res.status(200).send(t) :
        res.status(404).send('Title not found');
});

module.exports = libro;