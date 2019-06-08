#!/bin/bash

sudo az acr login -n kaota
sudo func kubernetes deploy --name mau201906 --registry kaota.azurecr.io
