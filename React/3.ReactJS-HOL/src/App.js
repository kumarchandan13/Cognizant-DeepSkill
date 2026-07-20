import './App.css';
import { CalculateScore } from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore
        Name="Anisha"
        School="DNV Public School"
        total={284}
        goal={3}
      />
    </div>
  );
}

export default App;