## Docker Keycloak 🐳

```powershell
docker run -p 9090:8080 -e KEYCLOAK_ADMIN=admin -e KEYCLOAK_ADMIN_PASSWORD=admin quay.io/keycloak/keycloak:22.0.5 start-dev
```


Export keycloak configs
```powershell
docker exec -it <container_id> sh
```

```powershell
cd /opt/keycloak/bin/
```

```powershell
./kc.sh export --file /tmp/keycloak.json
```

```powershell
docker cp <container_id>:/tmp/keycloak.json ./keycloak/
```