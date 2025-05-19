# Dockerfile
# Use the official Node.js image with Node 18 on Alpine Linux
FROM node:18-alpine as builder

# Set the working directory in the container
WORKDIR /app

# Copy the package.json and package-lock.json to install dependencies
COPY package*.json ./

# Install dependencies
RUN npm install

# Set the environment variable VITE_API_BASE_URL using a build argument
ARG VITE_API_BASE_URL
ENV VITE_API_BASE_URL=$VITE_API_BASE_URL

# Copy the .env file with the desired environment variable
COPY .env .

# Copy the rest of the application source code
COPY . .

# Build the Vite React app
RUN npm run build

# Stage 2: Create a smaller image for serving the built app
FROM node:18-alpine

# Set the working directory in the container
WORKDIR /app

# Install http-server to serve the static files
RUN npm install -g http-server

# Expose port 80 for HTTP
EXPOSE 80

# Copy the built static files from the builder stage
COPY --from=builder /app/dist .

# Command to start the HTTP server
CMD ["http-server", "-p", "80"]