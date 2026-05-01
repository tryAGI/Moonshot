#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://platform.kimi.ai/docs/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://platform.kimi.ai/docs/openapi.json
autosdk generate openapi.yaml \
  --namespace Moonshot \
  --clientClassName MoonshotClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
