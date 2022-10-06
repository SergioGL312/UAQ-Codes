const express = require('express');
const user = express.Router();
const login = require('../json/login.json');

user.get('/all', (req, res) => {
    res.status(200).send(login);
});

user.get('/:id([0-9]{1})', (req, res) => {
    const id = req.params.id;
    if (id >= 1 && id <= 4) {
        res.status(200);
        return res.send(login[id - 1]);
    }
    res.status(404);
    res.send('User Not Found');
});

user.get('/:username([A-Za-z0-9]+)', (req, res) => {
    const name = req.params.username;
    console.log(name);
    const un = login.filter((x) => {
        return (x.username.toUpperCase() === name.toUpperCase()) ? 
            x : null;
    });

    (un.length > 0) ?
        res.status(200).send(un) :
        res.status(404).send("Username not found");
});


module.exports = user;