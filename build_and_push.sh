#!/bin/bash
set -e  # зупиняє скрипт при помилці

cd Quizzy
docker build -t quizzy --platform linux/amd64,linux/arm64 .
docker tag quizzy:latest utereskovi/quizzy:latest
docker push utereskovi/quizzy:latest

echo "Done ---quizzy push---!"

read -p "Press any key to exit..."
 