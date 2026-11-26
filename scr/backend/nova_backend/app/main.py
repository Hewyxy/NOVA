from fastapi import FastAPI

app = FastAPI(
    title="NOVA Backend",
    description="Local AI assistant backend",
    version="0.1.0"
)


@app.get("/")
async def root():
    return {
        "name": "NOVA",
        "status": "running"
    }


@app.get("/health")
async def health_check():
    return {
        "status": "healthy"
    }