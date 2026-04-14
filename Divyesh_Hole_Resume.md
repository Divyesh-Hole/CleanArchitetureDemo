# **Divyesh Hole**

**Full-Stack Developer** | Python | FastAPI | React | AI/LLM

[holedivyesh@gmail.com] | [www.linkedin.com/in/divyesh-hole-169498227] | [Mumbai]

---

## Professional Summary

Full-Stack Developer with 3+ years of experience building scalable, multi-tenant platforms using Python, FastAPI, and React. Specialized in integrating AI/LLM capabilities — including RAG pipelines, agentic workflows, and multi-model orchestration — into production-grade backend systems. Proficient in designing containerized microservice architectures with Docker, PostgreSQL, and distributed task processing.

---

## Technical Skills

| Category | Technologies |
|---|---|
| **Languages** | Python, JavaScript, SQL |
| **Backend** | FastAPI, Celery, REST APIs, WebSockets, JWT Authentication, RBAC |
| **Frontend** | React, React Flow (drag-and-drop), HTML/CSS |
| **AI / LLM** | LangChain, LangGraph, DSPy, LlamaIndex, Sentence Transformers, RAG Pipelines |
| **LLM Providers** | OpenAI, Anthropic Claude, Google Gemini |
| **Databases** | PostgreSQL, MongoDB, Redis, Weaviate (Vector DB) |
| **ORM & Migrations** | SQLAlchemy, SQLModel, Alembic, Beanie (MongoDB ODM) |
| **DevOps & Infra** | Docker, Docker Compose, RabbitMQ, Redis Stack, Nginx |
| **Tools** | Git, VS Code, Black, isort, Make |

---

## Professional Experience / Projects

### AIMM Platform — AI-Powered Multi-Tenant SaaS Platform

**Full-Stack Developer**

- Architected and developed a **multi-tenant backend** using FastAPI with isolated per-tenant PostgreSQL databases, supporting secure onboarding of new tenants via API with automatic DB provisioning and Alembic migrations
- Built **agentic AI workflows** using LangChain + LangGraph state graphs, implementing intent-based routing (DSPy) to dynamically dispatch user queries to specialized agents (Chat, RAG, Deal Registration, Email Template)
- Designed and integrated **RAG pipelines** with Weaviate vector database (multi-tenant enabled), LlamaIndex for document indexing/chunking, and embedding models for semantic search with configurable similarity thresholds
- Implemented **multi-LLM orchestration** supporting OpenAI, Anthropic Claude, and Google Gemini with configurable temperature, model selection, and per-agent parameters
- Developed **background task processing** using Celery workers with RabbitMQ as the message broker, and Celery Beat for scheduled/periodic tasks
- Engineered a **hybrid memory and state management** system using Redis for LangGraph checkpointing, session management, and caching alongside PostgreSQL for persistent storage
- Implemented **JWT-based authentication** with role-based access control (RBAC) and API key management per tenant
- Set up **centralized logging and audit trails** using MongoDB with structured logging, agent execution tracing, and LLM usage tracking
- Orchestrated **8+ Docker containers** (FastAPI, PostgreSQL, Redis Stack, RabbitMQ, MongoDB, Weaviate, Celery Worker, Celery Beat) using Docker Compose with health checks, resource limits, and non-root user execution

**Tech:** Python, FastAPI, PostgreSQL, MongoDB, Redis, Weaviate, Celery, RabbitMQ, LangChain, LangGraph, DSPy, LlamaIndex, Docker, Alembic, SQLAlchemy

---

### Visual Workflow Builder — Drag-and-Drop Workflow Automation Tool

**Full-Stack Developer**

- Built a **visual workflow builder** with a React frontend enabling users to design automation pipelines through an intuitive drag-and-drop interface
- Developed interactive UI components for node configuration, edge connections, and real-time workflow validation
- Integrated the frontend with backend APIs to persist, retrieve, and execute user-defined workflows

**Tech:** React, Typescript, REST APIs

---

## Education

BE Electronics — Mumbai Univesity, 2022
