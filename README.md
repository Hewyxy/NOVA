# NOVA

**NOVA** is a local AI voice assistant for Windows, designed to provide natural voice interaction, execute user commands, and manage personal tasks using locally running AI models.

The project aims to build a desktop assistant that combines speech recognition, natural language processing, task execution, and text-to-speech in a single application.

> **Status:** In Development — Planning Stage

## Project Goals

- Create a desktop AI assistant for Windows.
- Enable natural voice interaction using a wake word.
- Process voice commands and determine user intent.
- Execute tasks through a deterministic command engine.
- Support reminders and other personal productivity features.
- Use local AI models to generate natural responses.
- Maintain user data locally.

## Technology Stack

### Desktop Application
- C#
- WPF
- XAML

### Backend
- Python
- FastAPI
- HTTP / WebSocket

### AI & Voice
- Ollama — Local LLM inference
- faster-whisper — Speech-to-text
- openWakeWord — Wake word detection
- Piper — Text-to-speech

### Database
- SQLite

### Development & Deployment
- Git
- GitHub
- Visual Studio
- PyInstaller
- Inno Setup

## Architecture

NOVA uses a desktop frontend written in C# and WPF, with a Python backend responsible for AI processing, voice recognition, command interpretation, and task execution.

```text
┌─────────────────────────────┐
│       WPF Desktop App       │
│          (C# / XAML)        │
│                             │
│  UI / Settings / System Tray│
└──────────────┬──────────────┘
               │
          HTTP / WebSocket
               │
┌──────────────▼──────────────┐
│       Python Backend        │
│          FastAPI            │
│                             │
│ ┌─────────────────────────┐ │
│ │    Voice Processing    │ │
│ │ Wake Word / STT / TTS  │ │
│ └─────────────────────────┘ │
│                             │
│ ┌─────────────────────────┐ │
│ │    Command Engine       │ │
│ │ Intent / Validation     │ │
│ │ Task Execution          │ │
│ └─────────────────────────┘ │
│                             │
│ ┌─────────────────────────┐ │
│ │     AI Integration     │ │
│ │       Ollama            │ │
│ └─────────────────────────┘ │
│                             │
│ ┌─────────────────────────┐ │
│ │       SQLite            │ │
│ │ Reminders / User Data   │ │
│ └─────────────────────────┘ │
└─────────────────────────────┘
```

### Command Processing

NOVA separates AI-generated responses from system actions.

The Command Engine is responsible for interpreting commands, validating extracted information, and executing actions. The LLM is responsible for generating natural and context-aware responses.

The LLM does not directly execute system commands.

Example:

```text
User:
"Remind me tomorrow at 10 AM to call USCIS."

Command Engine:
1. Detect reminder intent.
2. Extract date, time, and reminder text.
3. Validate the requested information.
4. Save the reminder to SQLite.
5. Schedule the reminder.

LLM:
Generate a natural confirmation.
```

## Planned Features

- [ ] Voice activation through a wake word
- [ ] Speech recognition
- [ ] Natural language command processing
- [ ] Local AI conversation
- [ ] Personality customization
- [ ] Text-to-speech responses
- [ ] Reminders and scheduling
- [ ] Persistent local storage
- [ ] Desktop notifications
- [ ] System tray integration
- [ ] Application settings
- [ ] Windows installer

## Development Roadmap

| Phase | Description | Status |
|---|---|---|
| 0 | Project setup and documentation | In Progress |
| 1 | WPF fundamentals and desktop application | Planned |
| 2 | Python backend and FastAPI | Planned |
| 3 | C# and Python integration | Planned |
| 4 | Microphone and voice recognition | Planned |
| 5 | Command Engine | Planned |
| 6 | SQLite and reminders | Planned |
| 7 | Local LLM integration | Planned |
| 8 | Text-to-speech | Planned |
| 9 | Desktop UI, settings, and notifications | Planned |
| 10 | Testing and MVP release | Planned |

## Project Structure

```text
NOVA/
├── docs/
│   ├── ROADMAP.md
│   ├── ARCHITECTURE.md
│   └── DECISIONS.md
│
├── src/
│   ├── DesktopApp/
│   │   └── NOVA.Desktop/
│   │
│   └── Backend/
│       └── nova_backend/
│
├── tests/
│
├── README.md
└── .gitignore
```

## Development

NOVA is currently in the planning and initial development stage.

The first development milestone is establishing the repository, documentation, and a basic WPF desktop application before implementing the Python backend.

Development is focused on learning, maintainability, modular architecture, and incremental implementation.

## Project Timeline

- **Start Date:** November 23, 2026
- **Target MVP Release:** February 15, 2027
- **Developer:** Solo Developer

The development schedule is organized into weekly sprints, with a minimum target of 12 development hours per week.

## Philosophy

- Understand before coding.
- Prefer maintainable architecture.
- Keep system actions deterministic and validated.
- Use local models whenever practical.
- Test every major component.
- Document architectural decisions.
- Build incrementally instead of overengineering.

---

* N O V A — A personal assistant, built locally.*
