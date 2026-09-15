* { box-sizing: border-box; margin: 0; padding: 0; }

:root {
  --bg: #0f1115;
  --card: #1a1d23;
  --border: #2a2e36;
  --text: #e8eaed;
  --muted: #9aa0a6;
  --accent: #4ade80;
  --accent-dark: #22c55e;
  --danger: #ef4444;
  --warning: #f59e0b;
}

body {
  font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, sans-serif;
  background: var(--bg);
  color: var(--text);
  padding-bottom: 70px;
  min-height: 100vh;
}

.top-bar {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 16px 20px;
  border-bottom: 1px solid var(--border);
  position: sticky;
  top: 0;
  background: var(--bg);
  z-index: 10;
}

.top-bar h1 { font-size: 18px; }

.icon-btn {
  background: none;
  border: none;
  font-size: 22px;
  cursor: pointer;
}

#content { padding: 20px; }

h2 {
  font-size: 16px;
  margin: 20px 0 12px;
  color: var(--muted);
  text-transform: uppercase;
  letter-spacing: 0.5px;
}

.hidden { display: none; }

.snapshot-grid {
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 12px;
}

.snap-card {
  background: var(--card);
  border: 1px solid var(--border);
  border-radius: 12px;
  padding: 16px;
  display: flex;
  flex-direction: column;
  gap: 4px;
}

.snap-label { font-size: 12px; color: var(--muted); }
.snap-value { font-size: 24px; font-weight: 600; }
.snap-unit { font-size: 12px; color: var(--muted); }

.quick-actions {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  gap: 10px;
}

.action-card {
  background: var(--card);
  border: 1px solid var(--border);
  border-radius: 12px;
  padding: 14px 8px;
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 6px;
  color: var(--text);
  text-decoration: none;
  font-size: 12px;
}

.action-card span:first-child { font-size: 22px; }

button, .btn {
  background: var(--accent);
  color: #000;
  border: none;
  border-radius: 10px;
  padding: 12px 20px;
  font-size: 15px;
  font-weight: 600;
  cursor: pointer;
  width: 100%;
  margin-top: 10px;
}

button:hover { background: var(--accent-dark); }

input, select, textarea {
  width: 100%;
  padding: 12px;
  background: var(--card);
  border: 1px solid var(--border);
  border-radius: 10px;
  color: var(--text);
  font-size: 15px;
  margin-bottom: 12px;
}

label {
  display: block;
  font-size: 13px;
  color: var(--muted);
  margin-bottom: 6px;
}

.bottom-nav {
  position: fixed;
  bottom: 0;
  left: 0;
  right: 0;
  display: flex;
  background: var(--card);
  border-top: 1px solid var(--border);
  padding: 8px 0;
  z-index: 100;
}

.bottom-nav a {
  flex: 1;
  text-align: center;
  color: var(--muted);
  text-decoration: none;
  font-size: 10px;
  display: flex;
  flex-direction: column;
  gap: 3px;
  padding: 4px;
}

.bottom-nav a span { font-size: 20px; }
.bottom-nav a.active { color: var(--accent); }
