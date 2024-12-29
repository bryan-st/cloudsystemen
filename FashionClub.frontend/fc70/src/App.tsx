import { RouterProvider, createBrowserRouter } from 'react-router-dom'
import { DataProvider } from './contexts/dataContext';
import Root from './components/root/root'
import HomePage from './components/HomePage/HomePage';
import DetailPage from './components/DetailPage/DetailPage';
import 'bootstrap/dist/css/bootstrap.min.css';
import { ReportProvider } from './contexts/reportContext';

function App() {
  const router = createBrowserRouter([
    {
      path: "/",
      element: <Root />,
      children: [
        {
          path: "",
          element: <HomePage />
        },
        {
          path: "/:id",
          element: <DetailPage />
        },
        {
          path: "/:id/:tab",
          element: <DetailPage />
        }
      ]
    }
  ])

  return (
    <DataProvider>
      <ReportProvider>
        <RouterProvider router={router} />
      </ReportProvider>
    </DataProvider>
  )
}

export default App
