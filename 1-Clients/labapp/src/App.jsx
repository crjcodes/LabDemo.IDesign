import { useState, useEffect } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

async function handleFetchPing() {
    try {
        const response = await fetch(
            "https://localhost:7210/ping/",  {
                method: "GET",
                mode: "no-cors",
                cache: "non-cache",
                credentials: "same-origin",
                headers: {
                    "Content-Type": "application/json"
                },
                redirect: "follow",
                referrer: "no-referrer"
            }
        );

        response
            .then(async response => {
                if (response == undefined || !response.ok) {
                    return Promise.reject(response.statusText);
                }
            })
            .then(async response => {
                console.log(response);
                const status = response.status;
                console.log(status);
                const pingMessage = await response.json();
                console.log(pingMessage);

                return pingMessage;
            });
    }
    catch (error) {
        console.error("A problem pinging the entry manager", error);
    }
}

async function App() {
    const [pingResponseData, setPingResponseData] = useState(null);

    const result = await handleFetchPing();
    useEffect(() => { setPingResponseData(result) }, [result]);

  return (
    <>
      <div>
        <a href="https://vitejs.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
          </p>
        <div className="card">              
              <div>{pingResponseData ? <pre>{pingResponseData}</pre> : 'Loading'
              }</div>
        </div>
    </>
  )
}

export default App