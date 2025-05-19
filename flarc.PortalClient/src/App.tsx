import {HomeComponent} from './components'

function App() {

  return (
      <div className="nhsuk-width-container">
        <main className="nhsuk-main-wrapper" id="maincontent">
          <div className="nhsuk-grid-row">
            <div className="nhsuk-grid-column-two-thirds">
              <HomeComponent/>
            </div>
          </div>
        </main>
      </div>
)
  ;
}

export default App;
